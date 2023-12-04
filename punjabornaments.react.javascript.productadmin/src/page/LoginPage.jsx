import React from 'react';
import Dashboard from '../page/Dashboard'
import LoginComponent from '../page/componrnt/LoginComponent'
function LoginPage() {
    useEffect(() => {
        CheckforLogginUserAsync();
    }, []);
    async function CheckforLogginUserAsync() {
        const isexist = isTokenExist();
        if (isexist) {
            //const userdetail = await getuserDetail();
            //setLogginUser(userdetail);
            return (<Dashboard />);
        }
        else {
            return (<LoginComponent />)
        }
    }
}

export default LoginPage;