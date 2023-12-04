import LoginPage from '../pages/LoginPage';
import Dashboard from '../pages/Dashboard'


export const RoutePaths = [
    {
        Path: '/',
        Title: "Login",
        Component: LoginPage,
    },
    {
        Path: "/Dashboard",
        Title: "Dashboard",
        Component: Dashboard
    },

]