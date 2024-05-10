﻿using AutoMapper;
using DiegoMoyanoProject.Models;
using DiegoMoyanoProject.ViewModels.Login;
using DiegoMoyanoProject.ViewModels.Mail;
using DiegoMoyanoProject.ViewModels.User;
using DiegoMoyanoProject.ViewModels.UserData;
using DiegoMoyanoProject.ViewModels.UserPdf;

namespace DiegoMoyanoProject.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, CreateUserViewModel>().
            ReverseMap();

            CreateMap<User, UpdateUserViewModel>().
            ReverseMap();

            CreateMap<User, UserViewDataViewModel>().
            ReverseMap();

            CreateMap<User, UserOfIndexUserViewModel>().
            ReverseMap();

            CreateMap<ImageData, ImageDataViewModel>().
            ReverseMap();

            CreateMap<ImageData, UploadImageFormViewModel>().
             ReverseMap();
            CreateMap<ImageData, UpdateImageFormViewModel>().
             ReverseMap();

            CreateMap<Email, InvertirEmailViewModel>().
                ReverseMap();

            CreateMap<Email, RetirarEmailViewModel>().
                ReverseMap();
            CreateMap<User, ViewInversionViewModel>().
                ReverseMap();
        }
    }
}
