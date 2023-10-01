
import { POSTAsync } from "./RESTService"

const LoginAction = async (authdetail) => {
    return POSTAsync(authdetail);
}

export{
    LoginAction
}