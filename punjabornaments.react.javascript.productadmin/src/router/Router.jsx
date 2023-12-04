import { Routes, Route } from 'react-router-dom'
import RoutePaths from '../constants/RoutePaths'
import PrivateRoute from '../router/PrivateRoute'

function Router() {
    return (
        <Routes>
            {
                RoutePaths.map((data, i) => {
                    console.log("data", data)
                    return <Route key={i} path={data.Path} element={<PrivateRoute Component={data.Component} />} />
                })
            }

            {/*return <Route path={data.} element={< LoginPage />} />*/}
            {/*<Route path='/' element={<LoginPage />} />*/}
            {/*<Route path='/Dashboard' element={ CheckforUserlogin() ?   <Dashboard/> : <LoginPage /> } />*/}
        </Routes>
  );
}

export default Router;