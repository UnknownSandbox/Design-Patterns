using System;
using System.Collections;
using System.Threading;

namespace PatternsLib.Patterns.ObjectPool
{
    public class ObjectPool<T> where T : class
    {
        /// <summary>
        /// Объект синхронизации
        /// </summary>
        private readonly Semaphore _semaphore;

        /// <summary>
        /// Коллекция содержит управляемые объекты
        /// </summary>
        private readonly ArrayList _pool;

        /// <summary>
        /// Ссылка на объект, которому делегируется ответственность 
        /// за создание объектов пула
        /// </summary>
        private readonly ICreation<T> _creator;

        /// <summary>
        /// Количество объектов, существующих в данный момент
        /// </summary>
        private Int32 _instanceCount;

        /// <summary>
        /// Максимальное количество управляемых пулом объектов
        /// </summary>
        private Int32 _maxInstances;

        /// <summary>
        /// Создание пула объектов
        /// </summary>
        /// <param name="creator">Объект, которому пул будет делегировать ответственность
        /// за создание управляемых им объектов</param>
        public ObjectPool(ICreation<T> creator)
            : this(creator, Int32.MaxValue)
        {
        }

        /// <summary>
        /// Создание пула объектов
        /// </summary>
        /// <param name="creator">Объект, которому пул будет делегировать ответственность
        /// за создание управляемых им объектов</param>
        /// <param name="maxInstances">Максимальное количество экземпляров класс,
        /// которым пул разрешает существовать одновременно
        /// </param>
        public ObjectPool(ICreation<T> creator, Int32 maxInstances)
        {
            this._creator = creator;
            this._instanceCount = 0;
            this._maxInstances = maxInstances;
            this._pool = new ArrayList();
            this._semaphore = new Semaphore(0, this._maxInstances);
        }

        /// <summary>
        /// Возвращает количество объектов в пуле, ожидающих повторного
        /// использования. Реальное количество может быть меньше
        /// этого значения, поскольку возвращаемая 
        /// величина - это количество "мягких" ссылок в пуле.
        /// </summary>
        public Int32 Size
        {
            get
            {
                lock (_pool)
                {
                    return _pool.Count;
                }
            }
        }

        /// <summary>
        /// Возвращает количество управляемых пулом объектов,
        /// существующих в данный момент
        /// </summary>
        public Int32 InstanceCount
        {
            get { return _instanceCount; }
        }

        /// <summary>
        /// Получить или задать максимальное количество управляемых пулом
        /// объектов, которым пул разрешает существовать одновременно.
        /// </summary>
        public Int32 MaxInstances
        {
            get { return _maxInstances; }
            set { _maxInstances = value; }
        }

        /// <summary>
        /// Возвращает из пула объект. При пустом пуле будет создан
        /// объект, если количество управляемых пулом объектов не 
        /// больше или равно значению, возвращаемому методом 
        /// <see cref="ObjectPool{T}.MaxInstances"/>. Если количество управляемых пулом 
        /// объектов превышает это значение, то данный метод возварщает null 
        /// </summary>
        /// <returns></returns>
        public T GetObject()
        {
            lock (_pool)
            {
                T thisObject = RemoveObject();
                if (thisObject != null)
                    return thisObject;

                if (InstanceCount < MaxInstances)
                    return CreateObject();

                return null;
            }
        }

        /// <summary>
        /// Возвращает из пула объект. При пустом пуле будет создан
        /// объект, если количество управляемых пулом объектов не 
        /// больше или равно значению, возвращаемому методом 
        /// <see cref="ObjectPool{T}.MaxInstances"/>. Если количество управляемых пулом 
        /// объектов превышает это значение, то данный метод будет ждать до тех
        /// пор, пока какой-нибудь объект не станет доступным для
        /// повторного использования.
        /// </summary>
        /// <returns></returns>
        public T WaitForObject()
        {
            lock (_pool)
            {
                T thisObject = RemoveObject();
                if (thisObject != null)
                    return thisObject;

                if (InstanceCount < MaxInstances)
                    return CreateObject();
            }
            _semaphore.WaitOne();
            return WaitForObject();
        }



        /// <summary>
        /// Удаляет объект из коллекции пула и возвращает его 
        /// </summary>
        /// <returns></returns>
        private T RemoveObject()
        {
            while (_pool.Count > 0)
            {
                var refThis = (WeakReference) _pool[_pool.Count - 1];
                _pool.RemoveAt(_pool.Count - 1);
                var thisObject = (T) refThis.Target;
                if (thisObject != null)
                    return thisObject;
                _instanceCount--;
            }
            return null;
        }

        /// <summary>
        /// Создать объект, управляемый этим пулом
        /// </summary>
        /// <returns></returns>
        private T CreateObject()
        {
            T newObject = _creator.Create();
            _instanceCount++;
            return newObject;

        }

        /// <summary>
        /// Освобождает объект, помещая его в пул для
        /// повторного использования
        /// </summary>
        /// <param name="obj"></param>
        /// <exception cref="NullReferenceException"></exception>
        public void Release(T obj)
        {
            if (obj == null)
                throw new NullReferenceException();
            lock (_pool)
            {
                var refThis = new WeakReference(obj);
                _pool.Add(refThis);
                _semaphore.Release();
            }
        }
    }
}
