import {
    Box,
    Card,
    CardContent,
    Typography,
    Button,
    TextField,
    Stack,
} from '@mui/material';
import React from 'react'

import { CenterComponent , FullScreantheComponent} from '../../assets/Style';

export default function login() {
    const [Username, setUsername] = React.useState("");
    const [Password, setPassword] = React.useState("");

    return (
            <Card>
                <CardContent>
                    <Typography sx={{ ...CenterComponent}}>
                        LOGIN ACCOUNT
                    </Typography>
                    <br/>
                    <TextField
                        label="User Name"
                        variant="outlined"
                        value={Username} />
                    <br />
                    <br />
                    <TextField
                        label="Password"
                        variant="outlined"
                        border="solid orange"
                        value={Password} />
                    <br />
                    <br />
                    <Button size="small">Login</Button>

                </CardContent>
            </Card>
    )
}
