import type { Route } from './+types/portfolios'
import PortfoliosPage from '~/pages/PortfoliosPage'

export function meta({}: Route.MetaArgs) {
  return [
    { title: "FinShark: Portfolios" },
    { name: "description", content: "List of user's portfolios" },
  ];
}

export default function Portfolios() {
  return <PortfoliosPage />
}
