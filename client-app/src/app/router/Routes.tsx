import { RouteObject, createBrowserRouter } from "react-router-dom"
import App from "../layout/App"
import Homepage from "../../features/Homepage"
import PersonalDetail from "../../features/PersonalDetail"

export const routes: RouteObject[] = [
    {
        path: '/',
        element: <App />,
        children: [
            {path: '/', element: <Homepage />},
            {path: '/personaldetail', element: <PersonalDetail />},
        ]
    }
]

export const router = createBrowserRouter(routes)