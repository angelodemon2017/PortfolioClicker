namespace Utils
{
    public class BigInt
    {
        private int _mainPart = 0;
        private int _rank = 0;
        private string _markChars = "abcdefghijklmnopqrstuvwxyz";

        public BigInt()
        {

        }

        public BigInt(int mainPart, int rank = 0)
        {
            _mainPart = mainPart;
            _rank = rank;
        }

        public override string ToString()
        {
            return Get();
        }

        public string Get()
        {
            if (_mainPart < 1000)
            {
                return $"{_mainPart}";
            }

            string result = $"{_mainPart}".Substring(0,3);

            var tempRank = _rank;

            if (_mainPart > 999 && tempRank == 0)
            {
                tempRank = $"{_mainPart}".Length - 3;
            }

            int pointIndex = tempRank % 3;

            if (pointIndex is > 0 and < 3)
            {
                result = result.Insert(pointIndex, ".");
            }

            result = $"{result}{GetRank(tempRank)}";

            return result;
        }

        private string GetRank(int tempRank)
        {
            var markIndex = (tempRank - 1) / 3;
            //            int pointIndex = tempRank % 3;

            if (markIndex == 0)
            {
                return $"{_markChars[0]}";
            }

            string resultMark = "";

            while (markIndex > 0)
            {
                int remainder = (markIndex - 1) % _markChars.Length;
                resultMark = resultMark.Insert(0, $"{_markChars[remainder]}");
                markIndex = (markIndex - 1) / _markChars.Length;
            }

            return resultMark;
        }
    }
}