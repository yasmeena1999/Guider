﻿using FluentValidation;

namespace Guider.Application.UseCases.Consultants.Command.UpdateBankAccount
{
    public class UpdateBankAccountCommandValidator : AbstractValidator<UpdateConsultantBankAccountCommand>
    {
        public UpdateBankAccountCommandValidator()
        {

            RuleFor(x => x.BankAccount)
                .NotEmpty().WithMessage("Bank account number is required.")
                .Matches(@"^\d{10,}$").WithMessage("Bank account number must be at least 10 digits.");
        }
    }

}
