
const LoginUser = async (request) => {
    const data = {
        Username: request.get("email"),
        Password: request.get("password")
    }
    const response = await POSTMethod(data, "http://localhost:5000/api/Account/login");// PathUrlForApi.Loginurl());
    if (response != null && response != undefined) {
        const Requiredreqponse = response.data;
        return Requiredreqponse
    }
}

export {
    LoginUser
}