import { useState, useEffect, Dispatch, SetStateAction} from 'react'
import { isTokenExist } from "../service/localstorage/TokenService"
//import { INavigation } from '../model/navigation/INavigation'
import LoginPage from '../pages/LoginPage.tsx'
import React from 'react'

interface IProp {
    Component: React.ReactNode
}

//const PrivateRoute: FC<IProp> = (props): ReactNode => {

const PrivateRoute = (props: IProp) => {
    //const [Islogin, setislogin] = useState<boolean>(false)
   //const Component: JSX.Element = props;
    //useEffect(() => {
    //    CheckforUserlogin(setislogin)
    //}, []);

    return (
        <React.Fragment>{props.Component}</React.Fragment>)

        //<>
        //    {
        //        Islogin ? < main > {props.Component}</main > : <LoginPage />
        //    }
        //</>
        //)
}
function CheckforUserlogin(setisuserlogin: Dispatch<SetStateAction<boolean>>) {
    const result = isTokenExist();
    console.log("isTokenExist", result)
    setisuserlogin(result)
}
export default PrivateRoute;