const baseurl = "https://localhost:5001";
export class PathUrlForApi
{
    static Loginurl = (): string => 
    {
        return baseurl + "/api/Account/login"
    } 
}