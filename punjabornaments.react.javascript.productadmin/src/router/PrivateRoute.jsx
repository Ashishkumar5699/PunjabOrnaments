import { useState, useEffect } from 'react'
import LoginPage from '../page/LoginPage';
import { isTokenExist } from '../service/localstorage/TokenService'

function PrivateRoute(props) {
    //const [Islogin, setislogin] = useState(false)
    useEffect(() => {
        //CheckforUserlogin(setislogin)
    }, []);
    //if (Islogin)
     //   return props.Component;
    return (<LoginPage />)
}
function CheckforUserlogin(setisuserlogin) {
    const result = isTokenExist();
    console.log("isTokenExist", result)
    setisuserlogin(result)
}
export default PrivateRoute;