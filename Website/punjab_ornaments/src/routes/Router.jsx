import React from 'react'
import { Routes, Route } from 'react-router-dom';

export default function Router() {
    return (
        <Routes>
            <Route>
                <Route path='/' element={<h1>hello</h1>} />
            </Route>
        </Routes>
    )
}
