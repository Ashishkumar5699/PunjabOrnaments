const baseurl = "http://localhost:5000/";
export class PathUrlForApi
{
    static Loginurl = (): string => 
    {
       return baseurl + "api/login"
    } 
}