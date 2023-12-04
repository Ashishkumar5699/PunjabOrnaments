import { Routes, Route } from 'react-router-dom'
import { RoutePaths } from "../Constants/RoutePaths"
import PrivateRoute from "../router/PrivateRoute"
import { INavigation } from "../model/navigation/INavigation"

function Router() {
    return (
        <Routes>
            {
                RoutePaths.map((data: INavigation, i: number) => {
                    console.log(data)
                    return <Route key={i} path={data.Path} element={<PrivateRoute Component={data.Component} />} />
                })
            }
        </Routes>
    );
}

export default Router;
