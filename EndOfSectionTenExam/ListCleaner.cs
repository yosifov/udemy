namespace EndOfSectionTenExam
{
    using System.Collections;

    public class ListCleaner
    {
        private ArrayList currentList;
        private ArrayList numericalList;

        public ListCleaner(ArrayList list)
        {
            this.currentList = list;
            this.numericalList = new ArrayList();
        }

        public void CleanList()
        {
            foreach (var item in this.currentList)
            {
                if (int.TryParse(item.ToString(), out int number))
                {
                    this.numericalList.Add(number);
                }
            }
        }

        public int GetNumericalListSum()
        {
            var sum = 0;
            foreach (var number in this.numericalList)
            {
                sum += int.Parse(number.ToString());
            }

            return sum;
        }
    }
}
