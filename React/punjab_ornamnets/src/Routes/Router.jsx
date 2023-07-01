import React from 'react'
import { Routes, Route } from 'react-router-dom';
import LoginPage from '../Pages/LoginPage'
export default function () {
  return (
    <div>
        <Routes>
            <Route path="/*" element={<LoginPage/>}/>
            <Route path="/Login" element={<LoginPage/>}/>
        </Routes>
    </div>
  )
}
