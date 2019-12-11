namespace EndOfSectionTwelveExam
{
    public class PageObjectOne : IPageObject
    {
        public PageObjectOne()
        {
            this.PageName = "Page Name 1";
        }
        public string PageName { get; private set; }
    }
}
