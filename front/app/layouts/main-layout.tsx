import { Outlet } from 'react-router'
import MainLayoutHeader from '~/layouts/headers/main-layout-header'
import MainLayoutFooter from '~/layouts/footers/main-layout-footer'

export default function MainLayout() {
  return (
    <div>
      <MainLayoutHeader />

      <div className="main-layout-container">
        <Outlet />
      </div>

      <MainLayoutFooter />
    </div>
  )
}
