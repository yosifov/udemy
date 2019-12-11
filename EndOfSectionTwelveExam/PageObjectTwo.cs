namespace EndOfSectionTwelveExam
{
    public class PageObjectTwo : IPageObject
    {
        public PageObjectTwo()
        {
            this.PageName = "Page Name 2";
        }

        public string PageName { get; private set; }
    }
}
