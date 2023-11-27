export interface LoginUserModel {
    UserName: string,
    Password: string,
    Token?: string,
    Device?: string,
    IsUserloggedin?: boolean
}