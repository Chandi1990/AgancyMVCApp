//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AgancyData.Identity
//{
//        public class ApplicationUser : IdentityUser<long> , IApplicationUser
//    {
//        public string FirstName { get; set; }
//        public string MiddleName { get; set; }
//        public string LastName { get; set; }
//        public string Address1 { get; set; }
//        public string Address2 { get; set; }
//        public string Address3 { get; set; }
//        public int? UserTypeId { get; set; }
//        public int? DestinationId { get; set; }
//        public int? AuthPinCode { get; set; }
//        public int? PartnerId { get; set; }
//        public int Gender { get; set; }
//        public int IsCard { get; set; }
//        public int IsDependent { get; set; }
//        public int? CityId { get; set; }
//        public int? CountryId { get; set; }
//        public DateTime? DOB { get; set; }
//        public int? DocumentTypeId { get; set; }

//        /// <summary>
//        /// Member Id
//        /// format 
//        /// XXX-YYYYYY
//        /// XXX - partner id
//        /// YYYYYY - Random number
//        /// </summary>
//        public string MemberId { get; set; }

//        public virtual UserType UserType { get; set; }
//        [NotMapped]
//        public string AccessCode { get; set; }
//        [NotMapped]
//        public string Password { get; set; }

//    }

//    public class ApplicationRole : IdentityRole<long>
//    {

//    }

//    public class ApplicationUserRole : IdentityUserRole<long>
//    {

//    }

//    public class ApplicationUserClaim : IdentityUserClaim<long>
//    {
//    }

//    public class ApplicationUserLogin : IdentityUserLogin<long>
//    {

//    }

//    public class ApplicationRoleClaim : IdentityRoleClaim<long>
//    {

//    }

//    public class ApplicationUserToken : IdentityUserToken<long>
//    {

//    }

//    public class UserType
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string RoleId { get; set; }
//        public bool IsActive { get; set; }

//        public virtual ICollection<UserTypeRole> UserTypeRoles { get; set; }
//    }

//    public class UserTypeRole
//    {
//        public int Id { get; set; }
//        public int UserTypeId { get; set; }
//        public long RoleId { get; set; }
//        public virtual ApplicationRole Role { get; set; }
//        public virtual UserType UserType { get; set; }
//    }
//}
