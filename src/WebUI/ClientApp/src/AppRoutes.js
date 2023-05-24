
import { Home } from "./components/Home";
import { Reqister } from "./features/Cpanel/components/Register";
import { SignInOfAdmin as Login } from "./features/Cpanel/components/SignIn";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/Register',
    element: <Reqister />
  },
  {
    path: '/Login',
    element: <Login />
  }
];

export default AppRoutes;
