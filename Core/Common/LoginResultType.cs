namespace Common
{
    public enum LoginResultType : byte
    {
        Success = 1,

        InvalidUserNameOrPassword,

        UserIsNotActive,

        UserLockout,

        CannotAccessPermissions
    }
}