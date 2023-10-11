import React from 'react'
import { Routes, Route } from 'react-router-dom';
import LoginPage from '../pages/LoginPage';

export default function Router() {
    return (
        <Routes>
            <Route>
                <Route path='/' element={<LoginPage/>} />
            </Route>
        </Routes>
    )
}
