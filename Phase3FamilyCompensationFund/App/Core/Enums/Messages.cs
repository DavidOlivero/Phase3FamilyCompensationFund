using System.ComponentModel;

namespace Phase3FamilyCompensationFund.App.Core.Enums;

public enum Messages
{
    [Description("La contraseña ingresada no es correcta, inténtelo de nuevo")]
    AuthenticationError,
    [Description("Asegúrese de rellenar todos los campos antes de continuar")]
    FormError,
    [Description("Los datos se guardaron correctamente")]
    FormSuccess,
    [Description("¿Está seguro que desea salir del formulario?")]
    ConfirmClosed,
    [Description("¿Está seguro que quiere limpial el formulario?")]
    ClearForm
}