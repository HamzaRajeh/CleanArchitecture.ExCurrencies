import ApiAuthorzationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { FetchData } from './components/FetchData';
  import { Home } from "./components/Home";
 import {Cpanel} from './features/Cpanel/Cpanel'

const AppRoutes = [
  {
    index: true,
    element: <Home />
  } ,  {
    path: '/fetch-data',
    requireAuth: true,
     element: <FetchData/>
  },
  {
    path: '/Cpanel',
    requireAuth: true,
     element: <Cpanel/>
  },
  ...ApiAuthorzationRoutes
];
export default AppRoutes;
