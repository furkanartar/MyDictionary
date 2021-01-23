namespace MyDictionary
{
    public class MyDictionary<T, X>
    {
        private T[] _firstArray;
        private T[] _secondArray;

        private T[] _tempFirtsArray;
        private T[] _tempSecondArray;

        public MyDictionary()
        {
            _firstArray = new T[0];
            _secondArray = new T[0];
        }

        public void Add(T firstItem, X secondItem)
        {
            _tempFirtsArray = _firstArray;
            _tempSecondArray = _secondArray;

            _firstArray = new T[_tempFirtsArray.Length + 1];
            _secondArray = new T[_tempSecondArray.Length + 1];

            for (int i = 0; i < _tempFirtsArray.Length; i++)
            {
                _firstArray[i] = _tempFirtsArray[i];
            }

            for (int i = 0; i < _tempSecondArray.Length; i++)
            {
                _secondArray[i] = _tempSecondArray[i];
            }

            _firstArray[_firstArray.Length - 1] = firstItem;
            _secondArray[_secondArray.Length - 1] = firstItem;
        }
    }
}