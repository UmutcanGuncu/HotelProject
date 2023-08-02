using System;
using FluentValidation;
using HotelProjectUILayer.Dtos.GuestDto;

namespace HotelProjectUILayer.ValidationRules.Guest
{
	public class UpdateGuestValidation: AbstractValidator<UpdateGuestDto>
    {
		public UpdateGuestValidation()
		{
            //Not Empty
            RuleFor(x => x.name).NotEmpty().WithMessage("İsim Bilgisi Boş Geçilemez");
            RuleFor(x => x.surname).NotEmpty().WithMessage("Soyadı Bilgisi Boş Geçilemez");
            RuleFor(x => x.city).NotEmpty().WithMessage("Şehir Bilgisi Boş Geçilemez");

            //Min Length
            RuleFor(x => x.name).MinimumLength(2).WithMessage("İsim Bilgisi Minimum 2 Karakter Olmalı ");
            RuleFor(x => x.surname).MinimumLength(3).WithMessage("Soyadı Bilgisi Minimum 3 Karakter Olmalı ");
            RuleFor(x => x.city).MinimumLength(3).WithMessage("Şehir Bilgisi Minimum 3 Karakter Olmalı ");

            //Max Length
            RuleFor(x => x.name).MaximumLength(30).WithMessage("İsim Bilgisi Maksimum 30 Karakter Olmalı");
            RuleFor(x => x.surname).MaximumLength(30).WithMessage("Soyadı Bilgisi Maksimum 30 Karakter Olmalı");
            RuleFor(x => x.city).MaximumLength(30).WithMessage("Şehir Bilgisi Maksimum 30 Karakter Olmalı");
        }
	}
}

