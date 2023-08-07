import { RouteObject, createBrowserRouter } from "react-router-dom"
import App from "../layout/App"
import Homepage from "../../features/Homepage"

export const routes: RouteObject[] = [
    {
        path: '/',
        element: <App />,
        children: [
            {path: '/', element: <Homepage />},
        ]
    }
]

export const router = createBrowserRouter(routes)