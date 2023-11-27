import {POSTMethod} from "../common/restservice.ts"
import { PathUrlForApi } from "../../assets/configurations.ts"
import { ResponseResult } from "../../model/ResponseResult.ts"
import { ILoginUser } from "../../model/auth/LoginUserModel.ts"

const LoginUser = async (request: FormData) => {
    const data = {
        Username : request.get("email"),
        Password : request.get("password")
    }
    const response = await POSTMethod<ResponseResult<ILoginUser>>(data, PathUrlForApi.Loginurl());
    if (response != null && response != undefined)
    {
        const Requiredreqponse: ResponseResult<ILoginUser> = response.data;
        return Requiredreqponse
    }
}

export {
    LoginUser
}