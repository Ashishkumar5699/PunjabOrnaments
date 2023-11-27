import { LoginUserModel } from "../model/auth/LoginUserModel.ts";

export function ValidateLoginDetails(logindataobj: LoginUserModel) {
    if (logindataobj != null && CheckForNullandUndefine(logindataobj.UserName) && CheckStringLengthToZero(logindataobj.UserName))
        if (CheckForNullandUndefine(logindataobj.Password) && CheckStringLengthToZero(logindataobj.Password))
            return true;

    return false;
}

function CheckStringLengthToZero(value : string) {
    if (value.length === 0)
        return false;
    return true;
}
function CheckForNullandUndefine(value: string): boolean {
    if (value != null && value != undefined)
        return true;
    return false;
}
