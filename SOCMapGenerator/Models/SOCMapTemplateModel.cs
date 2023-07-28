namespace SOCMapGenerator.Models
{
    public class SOCMapTemplateModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int PlayerCount { get; set; }
		public int NodeCount { get; set; }
    }

    public class SOCMapTemplateCreate : SOCMapTemplateModel
    {

    }
}
