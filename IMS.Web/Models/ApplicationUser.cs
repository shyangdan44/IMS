namespace IMS.Web.Models
{
    public class ApplicationUser
    {
        public string FullName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public int DepartmentId { get; set; }

        public int userRoleId { get; set; }

        public bool IsActived { get; set; }
        
        public string ProfilePicture { get; set; }

        public string ProfilePictureUrl { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set;}
    }
}
