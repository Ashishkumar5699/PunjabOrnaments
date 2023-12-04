import LoginComponent from './component/LoginComponent';
import { useEffect } from 'react'
import Dashboard from "../pages/Dashboard";
import { isTokenExist } from "../service/localstorage/TokenService"
//import { ILoginUser, defaultsLoginUser } from "../model/auth/ILoginUser"
import { getuserDetail } from "../service/localstorage/Userservice"

function LoginPage()
{
    //const [LogginUser, setLogginUser] = useState<ILoginUser>(defaultsLoginUser);
    //useEffect(() => {
    //    CheckforLogginUserAsync();
    //}, []);
    //async function CheckforLogginUserAsync() {
    //    const isexist: boolean = isTokenExist();
    //    if (isexist) {
    //        //const userdetail = await getuserDetail();
    //        //setLogginUser(userdetail);
    //     //   return (<Dashboard />);
    //    }
        return (<LoginComponent />)
}

export default LoginPage;