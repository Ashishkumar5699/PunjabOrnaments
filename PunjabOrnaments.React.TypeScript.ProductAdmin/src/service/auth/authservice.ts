import {POSTMethod} from "../common/restservice.ts"
import {PathUrlForApi} from "../../assets/configurations.ts"

const LoginUser = (data: any ) => {
    var url = PathUrlForApi.Loginurl()
    POSTMethod(data, url)
    console.log("Login function called")
}

export {
    LoginUser
}