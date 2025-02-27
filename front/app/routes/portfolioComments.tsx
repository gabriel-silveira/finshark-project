import type { Route } from './+types/portfolioComments'
import PortfolioCommentsPage from '~/pages/PortfolioCommentsPage'

export function meta({}: Route.MetaArgs) {
  return [
    { title: 'FinShark: Portfolio comments' },
    { name: 'description', content: 'Comments about this portfolio' }
  ]
}

export default function PortfolioComments() {
  return <PortfolioCommentsPage />
}
