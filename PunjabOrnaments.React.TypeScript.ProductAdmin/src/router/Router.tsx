import { Routes, Route } from 'react-router-dom'
import LoginPage from '../pages/LoginPage';
import Dashboard from "../pages/Dashboard";
//import { PathConstants } from "../Constants/RoutePaths"
function Router() {
    return (
        <Routes>
            {/*{PathConstants.map((navItem) => {*/}
            {/*    return <Route path={navItem.Path} element={< LoginPage />} />*/}
            {/*})}*/}

            <Route path='/' element={<LoginPage/>} />
            <Route path='/Dashboard' element={<Dashboard/>} />
        </Routes>
  );
}

export default Router;