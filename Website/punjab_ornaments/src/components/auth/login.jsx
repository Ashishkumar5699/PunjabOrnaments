import {
    Box,
    Card,
    CardContent,
    Typography,
    Button,
    TextField,
    Stack,
} from '@mui/material';
import {React, useState }from 'react'

import { CenterComponent , FullScreantheComponent} from '../../assets/Style';

export default function login() {
    const [Username, setUsername] = useState("");
    const [Password, setPassword] = useState("");

    const HandleUsernameChange = (e) => setUsername(valueGetter(e));
    const HandlePasswordChange = (e) => setPassword(valueGetter(e));

    const valueGetter = (e) => e.target.value
    
    const HandleLoginAction = () => {

        const authdetail = {
            Username,
            Password
        }

        console.log(authdetail)

    }

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
                        onChange={HandleUsernameChange}
                        value={Username} />
                    <br />
                    <br />
                    <TextField
                        label="Password"
                        variant="outlined"
                        border="solid orange"
                        onChange={HandlePasswordChange}
                        value={Password} />
                    <br />
                    <br />
                    <Button size="small" onClick={HandleLoginAction}>Login</Button>

                </CardContent>
            </Card>
    )
}
