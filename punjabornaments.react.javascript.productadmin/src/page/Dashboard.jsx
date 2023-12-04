import { Stack } from "@mui/material"

import NavBar from './componrnt/common/NavBar'

function Dashboard() {
  return (
      <Stack sx={{ width: "100vw", background: "red" }}>
          <NavBar />
          <h1>Welcome to Dashboard</h1>
      </Stack>
  );
}

export default Dashboard;