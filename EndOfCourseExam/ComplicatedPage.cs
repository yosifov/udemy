namespace EndOfCourseExam
{
    public class ComplicatedPage : BasePage
    {
        public ComplicatedPage()
            : base("Complicated page")
        {
        }

        public ComplicatedPage(
            SectionOfButtons buttonsSection, 
            SectionOfSocialMedia socialMediaSection, 
            SectionOfRandomStuff randomStuffSection) 
            : base("Complicated page")
        {
            this.ButtonsSection = buttonsSection;
            this.SocialMediaSection = socialMediaSection;
            this.RandomStuffSection = randomStuffSection;
        }

        public SectionOfButtons ButtonsSection { get; private set; }

        public SectionOfSocialMedia SocialMediaSection { get; private set; }

        public SectionOfRandomStuff RandomStuffSection { get; private set; }
    }
}
