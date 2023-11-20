
import { POSTAsync } from "./RESTService"
import {Login} from "../routes/URl"
const LoginAction = async (authdetail) => {
    return POSTAsync(Login, authdetail);
}

export{
    LoginAction
}