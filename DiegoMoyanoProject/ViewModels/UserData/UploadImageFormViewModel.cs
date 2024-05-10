using DiegoMoyanoProject.Models;
using System.ComponentModel.DataAnnotations;

namespace DiegoMoyanoProject.ViewModels.UserData
{
    public class UploadImageFormViewModel
    {

        [Required]
        [Display(Name="Tipo de Imagen")]
        public ImageType ImageType { get; set; }
        [Display(Name = "Imagen")]
        public IFormFile? InputFile { get; set; }

        public UploadImageFormViewModel()
        {
        }

        public UploadImageFormViewModel(ImageType imageType)
        {
            ImageType = imageType;
        }
    }
}
