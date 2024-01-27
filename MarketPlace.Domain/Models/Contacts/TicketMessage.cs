using MarketPlace.Domain.Models.Common;
using System.ComponentModel.DataAnnotations;
using MarketPlace.Domain.Models.User;

namespace MarketPlace.Domain.Models.Contacts
{
    public class TicketMessage : BaseEntity
    {
        #region properties

        public long TicketId { get; set; }

        public long SenderId { get; set; }

        [Display(Name = "متن پیام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Text { get; set; }

        #endregion

        #region relations

        public Ticket Ticket { get; set; }

        public ApplicationUser Sender { get; set; }

        #endregion
    }
}
