using System;
using AutoMapper;
using Sample02.Models;

namespace Sample02.AutoMapperConfig
{
    public class TestProfile1 : Profile
    {
        protected override void Configure()
        {
            // ��� ����� ������ ��� � �� ���� ���� ����� ����� �����
            this.CreateMap<DateTime, string>().ConvertUsing(new DateTimeToPersianDateTimeConverter());

            this.CreateMap<User, UserViewModel>();

            // ��� ����� �������� ���
            /*this.CreateMap<User, UserViewModel>()
             .ForMember(userViewModel => userViewModel.RegistrationDate,
                        opt => opt.ResolveUsing(src =>
                        {
                             var dt = src.RegistrationDate;
                             return dt.ToShortDateString();
                        }));*/
        }

        public override string ProfileName
        {
            get { return this.GetType().Name; }
        }
    }
}