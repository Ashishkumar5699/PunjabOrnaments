import React from 'react'

import { Box } from '@mui/material'

import Login from '../components/auth/login'
import { FullScreantheComponent, CenterComponent } from '../assets/Style'

export default function LoginPage() {

    return (
        <Box sx={{ ...FullScreantheComponent, ...CenterComponent, backgroundColor: '#F2F2F2' }}>
            <Login />
        </Box>

    )
}
