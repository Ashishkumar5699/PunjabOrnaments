import {POSTMethod} from "../common/restservice.ts"
import { PathUrlForApi } from "../../assets/configurations.ts"
import { ResponseResult } from "../../model/ResponseResult.ts"
import { LoginUserModel } from "../../model/auth/LoginUserModel.ts"

const LoginUser = async (request: FormData) => {
    const data = {
        Username : request.get("email"),
        Password : request.get("password")
    }
    const response = await POSTMethod<ResponseResult<LoginUserModel>>(data, PathUrlForApi.Loginurl());
    if (response != null && response != undefined)
    {
        const Requiredreqponse: ResponseResult<LoginUserModel> = response.data;
        return Requiredreqponse
    }
}

export {
    LoginUser
}