namespace ProgPoe.Models
{
    public class Document
    {

        public int DocumentId { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;

        public int ClaimId { get; set; }
        public MonthlyClaim? Claim { get; set; }
    }
    }

