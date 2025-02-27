import { type RouteConfig, index, route, layout } from '@react-router/dev/routes'

export default [
  layout('layouts/main-layout.tsx', [
    index('routes/home.tsx'),
    route('portfolios', 'routes/portfolios.tsx'),
    route('portfolio/comments', 'routes/portfolioComments.tsx'),
  ]),
] satisfies RouteConfig
