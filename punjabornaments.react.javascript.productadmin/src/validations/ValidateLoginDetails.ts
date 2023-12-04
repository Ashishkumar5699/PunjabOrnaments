
export function ValidateLoginDetails(logindataobj) {
    if (logindataobj != null && CheckForNullandUndefine(logindataobj.UserName) && CheckStringLengthToZero(logindataobj.UserName))
        if (CheckForNullandUndefine(logindataobj.Password) && CheckStringLengthToZero(logindataobj.Password))
            return true;

    return false;
}

function CheckStringLengthToZero(value) {
    if (value.length === 0)
        return false;
    return true;
}
function CheckForNullandUndefine(value) {
    if (value != null && value != undefined)
        return true;
    return false;
}