
const authtoken = "authtokenjs";

const setToken = async (token) => {
    await localStorage.setItem(authtoken, token)
}

const getToken = () => {
    const token = localStorage.getItem(authtoken)
    return token ?? '';
}

const isTokenExist = () => {
    const token = localStorage.getItem(authtoken)
    return token.length != 0;
}

export {
    setToken,
    getToken,
    isTokenExist
}