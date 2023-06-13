namespace Pet_match.Model
{
    public class Pet
    {
        public Guid petUid { get; set; }
        public string ownerUid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string  color { get; set; }
        public string gender { get; set; }
        public string petName { get; set; }
    }
}
