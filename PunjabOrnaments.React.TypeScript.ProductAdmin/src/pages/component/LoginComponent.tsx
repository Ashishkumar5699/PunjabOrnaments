﻿import {
    Container,
    TextField,
    Box,
    Avatar,
    Typography,
    CssBaseline,
    FormControlLabel,
    Checkbox,
    Button
} from '@mui/material';
import LockOutlinedIcon from '@mui/icons-material/LockOutlined';
import { LoginUser } from "../../service/auth/authservice.ts";
import { ValidateLoginDetails } from "../../validations/ValidateLoginDetails.tsx";
import { ILoginUser, defaultsLoginUser } from "../../model/auth/ILoginUser.ts"
import { useNavigate } from "react-router-dom";
import { setuserDetail } from "../../service/localstorage/Userservice.ts"


export default function LoginComponent() {
    const navigate = useNavigate();

    const handleSubmit = async (event: React.FormEvent<HTMLFormElement>) => {
        event.preventDefault();
        const data = new FormData(event.currentTarget);
        const dataobj: ILoginUser = convertFormdatatoObj(data);
        const isvalid = ValidateLoginDetails(dataobj);
        if (isvalid) {
            const result = await LoginUser(data);
            if (!result?.hasErrors && !result?.isSystemError) {
                console.log("navigate to dashboard")
                await setuserDetail(result!.data!)
                navigate("/Dashboard");
            }
            else {
                console.log(result.message)
            }
        }
        else {
            //popup
            console.log("username or password will never be empty")
        }
    };

    return (
        <Container component="main" maxWidth="xs">
            <CssBaseline />
            <Box
                sx={{
                    marginTop: 8,
                    display: 'flex',
                    flexDirection: 'column',
                    alignItems: 'center',
                }}
            >
                <Avatar sx={{ m: 1, bgcolor: 'secondary.main' }}>
                    <LockOutlinedIcon />
                </Avatar>
                <Typography component="h1" variant="h5">
                    Sign in
                </Typography>
                <Box component="form" onSubmit={handleSubmit} noValidate sx={{ mt: 1 }}>
                    <TextField
                        margin="normal"
                        required
                        fullWidth
                        id="email"
                        label="Email Address"
                        name="email"
                        autoComplete="email"
                        autoFocus />
                    <TextField
                        margin="normal"
                        required
                        fullWidth
                        name="password"
                        label="Password"
                        type="password"
                        id="password"
                        autoComplete="current-password" />
                    <FormControlLabel
                        control={<Checkbox value="remember" color="primary" />}
                        label="Remember me" />
                    <Button
                        type="submit"
                        fullWidth
                        variant="contained"
                        sx={{ mt: 3, mb: 2 }}
                    >
                        Sign In
                    </Button>
                    {/* <Grid container>
              <Grid item xs>
                <Link href="#" variant="body2">
                  Forgot password?
                </Link>
              </Grid>
              <Grid item>
                <Link href="#" variant="body2">
                  {"Don't have an account? Sign Up"}
                </Link>
              </Grid>
            </Grid> */}
                </Box>
            </Box>
        </Container>

    );

    function convertFormdatatoObj(data: FormData) {
        const dataobj: ILoginUser =
        {
            ...defaultsLoginUser,
            UserName: data.get("email") as string,
            Password: data.get("password") as string,
        }
        return dataobj;
    }
}
