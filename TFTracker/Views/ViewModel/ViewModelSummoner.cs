using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TFTracker.Views.ViewModel
{
    public class ViewModelSummoner
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Nome do Usuário")]
        public string userName { get; set; }
    }
}
