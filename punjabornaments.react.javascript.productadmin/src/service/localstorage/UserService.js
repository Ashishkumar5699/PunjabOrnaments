import { setToken, getToken, isTokenExist } from "./TokenService"

const loginuser_name = "loginuser_name";
//const loginuser_token: string = "loginuser_token";

const defaultsLoginUser = {
    UserName: '',
    Password: '',
    Token: '',
    Device: 'website',
    IsUserloggedin: false
}

export const setuserDetail = async (data) => {
    await localStorage.setItem(loginuser_name, data.UserName)
    await setToken(data.Token)
}

export const getuserDetail = async () => {
    const userdetail = {
        ...defaultsLoginUser,
    }

    const isexist = isTokenExist()
    if (isexist) {
        userdetail.UserName = await localStorage.getItem(loginuser_name) ?? '';
        userdetail.Token = await getToken()
        userdetail.IsUserloggedin = userdetail.Token.length != 0;
    }
    return userdetail;
}

export const removeuserDetail = async () => {

    const defaultdata = {
        ...defaultsLoginUser
    }
    setuserDetail(defaultdata);
}