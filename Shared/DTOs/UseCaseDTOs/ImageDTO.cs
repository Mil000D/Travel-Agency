﻿using MASProject.Shared.SharedValidators;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Shared.DTOs.UseCaseDTOs
{
    public class ImageDTO
    {
        [Required]
        [ImageValidation(new[] { ".jpg", ".png" })]
        public string ImageURL { get; set; } = null!;
    }
}
