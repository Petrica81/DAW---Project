namespace Ziare.Models
{
    public class ZiarEditorRelation
    {
        public Guid ZiarId { get; set; }
        public Ziar Ziar { get; set; }
        public Guid EditorId { get; set; }
        public Editor Editor { get; set; }

    }
}
