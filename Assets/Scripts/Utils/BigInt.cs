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

            int markIndex = tempRank / 3;

            result = $"{result}{GetRank(markIndex)}";

            return result;
        }

        private string GetRank(int markIndex)
        {
            string resultMark = "";

            if (markIndex > 0)
            {
                while (markIndex > 0)
                {
                    int remainder = markIndex % _markChars.Length;
                    resultMark = resultMark.Insert(0, $"{_markChars[remainder]}");
                    markIndex /= _markChars.Length;
                }
            }
            else
            {
                resultMark = $"{_markChars[0]}";
            }

            return resultMark;
        }
    }
}